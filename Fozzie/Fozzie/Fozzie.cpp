#include "stdafx.h"
#include <windows.h>
#include <iostream>
#include "stdio.h" 

using namespace std;

typedef struct tagBITMAPFILEHEADER {
		WORD  bfType;
		DWORD   bfSize;
		WORD  bfReserved1;
		WORD  bfReserved2;
		DWORD   bfOffBits;
} BITMAPFILEHEADER, *PBITMAPFILEHEADER;


typedef struct tagBITMAPINFOHEADER {
		DWORD  biSize;        // size of structure, in bytes 
		DWORD  biWidth;      // bitmap width, in pixels 
		DWORD  biHeight;        // bitmap height, in pixels 
		WORD   biPlanes;        // see below 
		WORD   biBitCount;    // see below 
		DWORD  biCompression;   // see below 
		DWORD  biSizeImage;  // see below 
		DWORD  biXPelsPerMeter; // see below 
		DWORD  biYPelsPerMeter; // see below 
		DWORD  biClrUsed;      // see below 
		DWORD  biClrImportant;  // see below 
} BITMAPINFOHEADER;



HANDLE hfile;
DWORD written;
BITMAPFILEHEADER bfh;
BITMAPINFOHEADER bih;
RGBTRIPLE *image;

int main()
{
	// Open the file 
		hfile = CreateFile("fozzie-in.bmp", GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, NULL, NULL); 
		ReadFile(hfile, &bfh, sizeof(bfh), &written, NULL);
		ReadFile(hfile, &bih, sizeof(bih), &written, NULL);
		int imagesize = bih.biWidth*bih.biHeight; // Helps you allocate memory for the image 
		image = new RGBTRIPLE[imagesize]; // Create a new image (I'm creating an array during runtime)
		ReadFile(hfile, image, imagesize * sizeof(RGBTRIPLE), &written, NULL); // Reads it off the disk 
		// Close source file 
		CloseHandle(hfile);
		// Now for some information 
		cout << "The image width is " << bih.biWidth << "\n"; // Will output the width of the bitmap 
		cout << "The image height is " << bih.biHeight << "\n"; // Will output the height of the bitmap 

	return 0;
}
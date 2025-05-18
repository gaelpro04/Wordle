#include <windows.h>

__declspec(dllexport) int __stdcall suma(int a, int b) {
	return a + b;
}

__declspec(dllexport) int __stdcall resta(int a, int b) {
	return a - b;
}
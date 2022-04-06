// dllmain.cpp : DLL 애플리케이션의 진입점을 정의합니다.
#include "pch.h"

#include <stdio.h>


extern "C" __declspec(dllexport) int sum(int a, int b);
extern "C" __declspec(dllexport) void MyMessage(char* str);

int sum(int a, int b)
{
	return a + b;
}

void MyMessage(char* str)
{
	printf("str : %s \n", str);
}


#include <SDKDDKVer.h>
#include <WinSDKVer.h>

// Set oldest supported version to Windows 7
#undef _WIN32_WINNT
#define _WIN32_WINNT _WIN32_WINNT_WIN7 
#define NOCOMM
#define WIN32_LEAN_AND_MEAN

#include <windows.h>

#include "pca9498_com_local.h"

/* ==========================================================
 * Entry point
 * ==========================================================*/
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
		pca_com_init();
		break;
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
		break;
	case DLL_PROCESS_DETACH:
		pca_com_cleanup();
		break;
	}
	return TRUE;
}
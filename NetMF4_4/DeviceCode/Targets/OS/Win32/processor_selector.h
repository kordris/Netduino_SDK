////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#if !(defined(_WIN32) || defined(WIN32))
ERROR - WE SHOULD NOT INCLUDE THIS HEADER IF NOT BUILDING A WINDOWS PLATFORM
#endif

#ifndef _WINDOWS_PROCESSOR_SELECTOR_H_
#define _WINDOWS_PROCESSOR_SELECTOR_H_ 1

#undef FillMemory

#define PLATFORM_WIN32 1

#endif //_WINDOWS_PROCESSOR_SELECTOR_H_

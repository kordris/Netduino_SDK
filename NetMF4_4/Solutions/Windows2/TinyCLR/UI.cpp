////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include "stdafx.h"

#include <wininet.h>
#include <process.h>

////////////////////////////////////////////////////////////////////////////////////////////////////

BOOL Buttons_Initialize()
{
    return TRUE;
}

BOOL Buttons_Uninitialize()
{
    return FALSE;
}

BOOL Buttons_RegisterStateChange( UINT32 ButtonsPressed, UINT32 ButtonsReleased )
{
    return FALSE;
}

BOOL Buttons_GetNextStateChange( UINT32& ButtonsPressed, UINT32& ButtonsReleased )
{
    return 0;
}

UINT32 Buttons_CurrentState()
{
    return 0;
}

//--//

BOOL BackLight_Initialize()
{
    return FALSE;
}

void BackLight_Uninitialize()
{
}

void BackLight_Set( BOOL On )
{
}

void BackLight_RefCount( BOOL Add )
{
}

void BackLight_Force( BOOL On )
{
}
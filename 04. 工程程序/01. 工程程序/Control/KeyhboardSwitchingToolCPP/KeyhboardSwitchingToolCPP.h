
// KeyhboardSwitchingToolCPP.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������


// CKeyhboardSwitchingToolCPPApp: 
// �йش����ʵ�֣������ KeyhboardSwitchingToolCPP.cpp
//

class CKeyhboardSwitchingToolCPPApp : public CWinApp
{
public:
	CKeyhboardSwitchingToolCPPApp();

// ��д
public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CKeyhboardSwitchingToolCPPApp theApp;
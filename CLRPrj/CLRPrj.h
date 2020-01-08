#pragma once

#include "..\MfcExtPrj\\ClassMfc.h"

using namespace System;

namespace CLRPrj {
	public ref class ClassCLR
	{
		// TODO: 여기에 이 클래스에 대한 메서드를 추가합니다.
	private:
		ClassMfc *classMfc = new ClassMfc();

	public:
		int getNumber(int address);
	};
}

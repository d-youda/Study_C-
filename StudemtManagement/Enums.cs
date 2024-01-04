using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudemtManagement
{
    public enum Sex
    {
        //성별을 구분하는 Domain 지정
        남성, 여성, 미확인
    }

    public enum Grade
    {//숫자로 시작할 수 없다
        _1학년 = 1, _2학년 = 2, _3학년 = 3, 미확인 = 4
    }

    public enum StudentClass
    {
        _1반=1, _2반=2, _3반=3, _4반=4, _5반=5, _6반=6, _7반=7, _8반=8, _9반=9, _10반=10, 미확인=11
    }
}

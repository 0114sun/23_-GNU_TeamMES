using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//서비스 로직, 비즈니스 로직(딴)
//프로그램에 직접적인 영향을 주지 않는 대신 시스템 운영에 필요한 정보들을 모아두고 사용할수 있는 모듈

 namespace Services
{
    //클래스 라이브러리 , 프로젝트 파일 , DLL , 네임스페이스 , 어셈블리
    //하나 이상의 앱에서 호출되는 형식 및 메서드 등을 정의하여 DLL 로 제공한다.
    //외부 프로젝트에서 DLL 파일을 참조함으로서 DLL에 있는 클래스의 기능을 사용할수 있도록한다
    //재사용성, 유지보수성 증가.
    public class Commons
    {
        // Commons 
        // 시스템에서 사용하는 공통 변수 또는 메서드 등의 모음.
         
        //static
        //응용프로그램 실행시 최초 1회 초기화 할 때 DATA 영역에 등록이 되어 
        //응용프로그램이 종료 될때까지 상주해 있도록 하는 키워드
        //const 는 기본적으로 static 속성을 가지고있음.
        public const string Sconnection = "Server = PC-094\\MSSQLSERVER01; Uid = sa; Pwd = 1234; database = AppDev;";

        public static bool bloginFlag = false;
    }
}

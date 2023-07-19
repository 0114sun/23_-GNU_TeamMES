using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
         //   Application.EnableVisualStyles();
         //   Application.SetCompatibleTextRenderingDefault(false);
            //메인클래스가 실행되기전에 login 클래스 실행

            
          //  Form1 login = new Form1();
          //  login.ShowDialog();
            #region <정적변수를 이용한 메인화면 호출방법>
            //로그인이 성공을 했을때
            //아래의 메인창을 오픈해야한다.
            if (Commons.bloginFlag)
            {
                Application.Run(new M03_MainForm());
            }
            #endregion

            #region< 클래스 변수를 이용한 로그인 여부 확인 방법>
            //if (login.bLoginFlag)
            //{
            //    Application.Run(new M03_MainForm());
            //}
            #endregion
            #region <Tag를 사용한 방법>

            //string a = login.sUserName;

            //if(login.Tag != null && (bool)login.Tag ==true)
            //{
            //    Application.Run(new M03_MainForm(a));
            //}
            #endregion
            #region<어레이태그사용한 방법>
      //      ArrayList List = login.Tag as ArrayList; //Arraylist 에 없을수도 있으니 as
        //    if(List != null && (bool)List[0] == true) 
            {
                //         Application.Run(new M03_MainForm(List[1].ToString()));

                Application.Run(new M03_MainForm("관리자"));

                
            }
            #endregion
        }
    }
}

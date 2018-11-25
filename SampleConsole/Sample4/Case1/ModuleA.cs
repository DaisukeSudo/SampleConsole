using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case1
{
    public class ModuleA
    {
        public void LoadUserInfo() => SharedVariable.Value = FetchUserInfo();

        public IUserInfo GetUserInfo() => SharedVariable.Value;

        private UserInfoA FetchUserInfo() => new UserInfoA();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case1.Before
{
    public class ModuleB
    {
        public void LoadUserInfo() => SharedVariable.Value = FetchUserInfo();

        public IUserInfo GetUserInfo() => SharedVariable.Value;

        private UserInfoB FetchUserInfo() => new UserInfoB();
    }
}

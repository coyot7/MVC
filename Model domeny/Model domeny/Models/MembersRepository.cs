using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_domeny.Models
{
    public class MembersRepository : IMembersRepository
    {
        public void AddMember(Member member)
        { }

        public Member FetchByLoginName(string loginName)
        {
            return null;
        }

        public void SubmitChanges()
        { }
    }
}
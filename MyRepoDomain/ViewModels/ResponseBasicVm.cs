using System;
using System.Collections.Generic;
using System.Text;

namespace MyRepoDomain
{
    public class ResponseBasicVm
    {
        public bool Status { get; set; }

        public object Data { get; set; }
        public List<string> MsgBad { get; set; }
        public List<string> MsgOk { get; set; }
        public List<string> MsgAlert { get; set; }

        public ResponseBasicVm()
        {
            MsgBad = new List<string>();
            MsgOk = new List<string>();
            MsgAlert = new List<string>();
        }
    }
}

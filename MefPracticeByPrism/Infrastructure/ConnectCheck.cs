using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ConnectCheck
    {
        public String RadioID { get; set; } //라디오버튼 값 가져오기
        public ConnectionState ConnetedIsCheck { get; set; }// 연결 상태 체크 ? 뭐랑?
    }


    public enum ConnectionState
    {
        Connected,
        DisConnected
    }
}
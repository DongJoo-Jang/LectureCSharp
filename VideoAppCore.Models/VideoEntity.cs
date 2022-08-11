using System;
using System.Collections.Generic;
using System.Text;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [2]모델 클래스 작성
    /// 
    /// </summary>
    public class VideoEntity
    {
        //일련번호
        public int Id { get; set; }
        //등록일
        public DateTimeOffset Created { get; set; }
        //제목
        public string Title { get; set; }
        //경로
        public string Url { get; set; }
        //생성자
        public string Name { get; set; }
        //플랫폼
        public string Company { get; set; }

    }
}

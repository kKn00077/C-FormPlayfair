using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationProtect
{
    class PasswordEngineer
    {
        //변수
        // 평문 암호화를 위한 테이블, 평문을 2개씩 분리해 저장하기 위한 배열(메서드에서 변수를 통한 동적할당), 키워드 입력 받는 변수, 암호화가 된 문장을 저장할 변수
        List<Char> alpatable;
        private string[] divline; // 문장 분리
        private string keyword; // 키워드(소문자)
        private string cryptogram=""; //암호화된 문장
        private string plain; // 평문

        internal void Init()
        {
            cryptogram = "";
        }



        //배열에 값 삽입하는 메서드, set키워드 메서드에 들어감
        //키워드에서 중복되는 알파벳 제거하고 배열에 삽입
        //그 뒤에 알파벳 순서대로 배열에 삽입
        private void InsertTable()
        {   
            List<Char> table = new List<Char>();
            int length = keyword.Length;
            int count = 1;

            for (int i = 0; i < length; i++) {
                table.Add(keyword[i]);
                count++;
            }

            for(int i = 0; i < 25; i++)
            {
                table.Add((char)('a' + i));
            }

            alpatable = table.Distinct().ToList();
        }

        



        //암호화하는 함수
        internal void Encryption()
        {
            SearchTable();

            // 암호판에서 해당 문자를 찾고 그 행과 열에서 만나는 문자로 치환한다.
            // 만약 같은 행이나 열에 있을 경우 각각 오른쪽에 있는 문자, 아랫쪽에 있는 문자로 대체. 행과 열의 시작과 끝을 연결하는 것도 가능하다

            for (int i = 0; i < divline.Length; i++)
            {

                int first = alpatable.IndexOf(divline[i][0]);
                int second = alpatable.IndexOf(divline[i][1]);

                Debug.WriteLine(divline[i][0] + ", " + divline[i][1]);
                Debug.WriteLine(first + ", " + second);

                if (/*(first + 1)/5 == (second+1) / 5*/ (first!=0?first/5:0) == (second!=0?second/5:0))//같은 행일 경우
                {
                    if ((first + 1) % 5 == 0) // 첫번째 글자가 행의 맨 끝에 있을 경우
                    {
                        
                        cryptogram += alpatable[first - 4]+""+alpatable[second+1] + " ";
                    }
                    else if((second + 1) % 5 == 0) // 두번째 글자가 행의 맨 끝에 있을 경우
                    {
                        cryptogram += alpatable[first + 1] + "" + alpatable[second - 4] + " ";
                    }
                    else
                    {
                        cryptogram += alpatable[first + 1] + "" + alpatable[second + 1] + " ";
                    }

                }
                else if(/*(first+1)%5 == (second+1) % 5*/ (first != 0 ? first % 5 : 0) == (second != 0 ? second % 5 : 0)) //같은 열일 경우
                {
                    if(first/5==4)//첫번째 글자가 열의 맨 끝에 있을 경우
                    {
                        cryptogram += alpatable[first - 5*4] + "" + alpatable[second + 5] + " ";
                    }
                    else if(second / 5 == 4)//두번째 글자가 열의 맨 끝에 있을 경우
                    {
                        cryptogram +=   alpatable[first + 5] + "" + alpatable[second - 5 * 4] + " ";
                    }
                    else//
                    {
                        cryptogram += alpatable[first + 5] + "" + alpatable[second + 5] + " ";
                    }

                }
                else //다른 행 다른 열일 경우
                {
                    int multi;
                    if (first > second)//첫번째가 더 밑에 있을 때
                    {
                        multi = (first / 5 - (second != 0 ? second / 5 : 0))*5;

                        //cryptogram += alpatable[first - 5] + "" + alpatable[second + 5] + " ";
                        cryptogram += alpatable[first - multi] + "" + alpatable[second + multi]+" ";
                    }
                    else
                    {
                        //cryptogram += alpatable[first + 5] + "" + alpatable[second - 5] + " ";

                        multi = (second / 5 - (first != 0 ? first / 5 : 0)) * 5;
                        cryptogram += alpatable[first + multi] + "" + alpatable[second - multi] + " ";
                    }
                }
                
            }

        }

        //테스트 메서드
        private void SearchTable()
        {
            for(int i = 0; i < alpatable.Count(); i++)
            {
                Debug.WriteLine(alpatable[i]);
            }
        }


        //get복호화문장, set키워드, set평문, get암호화문장

        //set 평문, 평문을 변수에 넣어주고 분리하기
        internal void SetPlain(string plainLine)
        {

            //평문 분리해서 
            plain = plainLine;


            int start = 0;
            string add_xplain = plain.Replace(" ", "");
            List<Char> strs = new List<char>();
            int j;

            for(j = 0; j < add_xplain.Length-1; j+=2)
            {
                Debug.WriteLine(j);
                strs.Add(add_xplain[j]);

                if (add_xplain[j] == add_xplain[j + 1])
                {
                    j--;
                    strs.Add('x');
                }
                else
                {
                    strs.Add(add_xplain[j + 1]);
                }

            }

            //

            if(j!=add_xplain.Length) strs.Add(add_xplain[add_xplain.Length-1]);

            if (strs.Count() % 2 == 1)
            {
                
                strs.Add('x');
            }

            for(int i = 0; i < strs.Count(); i++)
            {
                Debug.WriteLine(strs[i]);
            }

            Debug.WriteLine(strs.Count());

            divline = new string[strs.Count() / 2];

            for(int i = 0; i < divline.Length; i++, start+=2)
            {
                divline[i] = ""+strs[start] + strs[start + 1];
                Debug.WriteLine(divline[i]);
            }

        }

        internal void SetKeyword(string key)
        {
            keyword = key;
            InsertTable();
        }

        internal string GetCryptogram()
        {
            return cryptogram;
        }

    }
}

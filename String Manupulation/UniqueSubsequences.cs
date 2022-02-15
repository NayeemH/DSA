using System;
 public class UniqueSubsequences 
    {  
        public static void Main(string[] args)  
        {  
            int testCase = Convert.ToInt32(Console.ReadLine());
            
            while(testCase>0){
                string str = Console.ReadLine();
                int count = 1;
                int len = str.Length;
                for(int i=1; i<len; i++){    
                    if(str[i] != str[i-1]){
                        count++;
                    }
                }
                Console.WriteLine(count);
                testCase--;
            }
            
        }  
    }  
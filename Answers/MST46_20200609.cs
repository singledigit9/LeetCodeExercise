namespace LeetCodeExercise.Answers
{
    /*
https://leetcode-cn.com/problems/ba-shu-zi-fan-yi-cheng-zi-fu-chuan-lcof/
面试题46. 把数字翻译成字符串
给定一个数字，我们按照如下规则把它翻译为字符串：0 翻译成 “a” ，1 翻译成 “b”，……，11 翻译成 “l”，……，25 翻译成 “z”。一个数字可能有多个翻译。请编程实现一个函数，用来计算一个数字有多少种不同的翻译方法。

示例 1:

输入: 12258
输出: 5
解释: 12258有5种不同的翻译，分别是"bccfi", "bwfi", "bczi", "mcfi"和"mzi"
 
提示：

0 <= num < 2^31 = 2147483648
     */
    
    public class MST46_20200609
    {
        //最先想到的是迈台阶的问题
        //所以想要用递归的方式解决
        public int TranslateNum(int num)
        {
            if (num < 10)
                return 1;

            int tail = num % 100;
            return TranslateNum(num / 10) + ((9 < tail && tail < 26) ? TranslateNum(num / 100) : 0);
        }

        //题解思路
        
        //其他思路
    }
}
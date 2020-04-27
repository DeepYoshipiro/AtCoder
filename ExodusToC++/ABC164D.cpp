#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

int main()
{
    char S[200005];
    cin >> S;

    int r[200008];
    r[0] = 1;
    for (int i = 1; i <= 200000; i++)
    {
        r[i] = r[i - 1] * 10;
        r[i] %= 2019;
    }

    long result = 0;
    for (int j = S.Length - 1; j >= 3; j--)
    {
        long Sum = S[j] - '0';
        for (int i = j - 1; i >= 0; i--)
        {
            Sum += (S[i] - '0') * r[j - i];
            Sum %= 2019;
            if (Sum == 0) result++;
        }
    }

    WriteLine(result.ToString());
    ReadKey();
}

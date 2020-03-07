// ABC133A.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include <algorithm>
using namespace std;

int main133()
{
    int N, A, B;
    cin >> N >> A >> B;
    int result = min(A * N, B);
    cout << result;
    return 0;
}

#include <algorithm>
#include <string>
#include <iostream>
#include <functional>
using namespace std;

bool check(string a, string b, int n, int m)
{
    int n1 = 0, m1 = 0;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (a[i] == b[j] && i == j) n1++;
            if (a[i] == b[j] && i != j) m1++;
        }
    }
    if (n == n1 && m == m1) return true;
    return false;
}

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);
    cout.tie(0);

    int t;
    cin >> t;
    bool num[1000];

    for (int i = 123; i < 1000; i++)
    {
        num[i] = true;
        string s = to_string(i);
        if (s[0] == '0' || s[1] == '0' || s[2] == '0') num[i] = false;
        if (s[0] == s[1] || s[1] == s[2] || s[0] == s[2])num[i] = false;
    }

    while (t--)
    {
        string n;
        int strike, ball;
        cin >> n >> strike >> ball;

        for (int i = 123; i < 1000; i++)
        {
            string m = to_string(i);
            if (!num[i]) continue;

            if (!check(n, m, strike, ball)) num[i] = false;
        }
    }
    
    int count = 0;
    for (int i = 123; i < 1000; i++)
        if (num[i]) count++;
    cout << count;
}

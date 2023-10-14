#include <algorithm>
#include <vector>
#include <iostream>
#include <functional>
using namespace std;

int n;
vector<int> v;

bool pre_permutation()
{
    int a = n - 1, b = 0;
    while (a > 0 && v[a - 1] <= v[a]) a--;
    if (a <= 0) return false;

    for (int i = n - 1; i >= 0; i--)
    {
        if (v[a - 1] > v[i])
        {
            b = i;
            break;
        }
    }
    swap(v[a - 1], v[b]);
    sort(v.begin() + a, v.end(), greater<>());
    return true;
}

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);
    cout.tie(0);

    cin >> n;
    for (int i = 0; i < n; i++)
    {
        int a; cin >> a;
        v.push_back(a);
    }
    if (pre_permutation())
    {
        for (int i = 0; i < n; i++)
            cout << v[i] << ' ';
    }
    else
        cout << -1;
}

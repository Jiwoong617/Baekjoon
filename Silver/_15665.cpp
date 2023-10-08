#include <set>
#include <vector>
#include <iostream>
using namespace std;

int n, m;
set<int> s;
vector<int> temp;

void BackT(int count)
{
    if (count >= m)
    {
        for (auto a : temp)
            cout << a << ' ';
        cout << '\n';
        return;
    }

    for(auto a: s)
    {
        temp.push_back(a);
        BackT(count + 1);
        temp.pop_back();
    }
}

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);
    cout.tie(0);
    
    cin >> n >> m;
    for (int i = 0;i < n; i++)
    {
        int a;
        cin >> a;
        s.insert(a);
    }
    BackT(0);
}

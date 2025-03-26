#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>

#define ll long long
using namespace std;

bool cmp(pair<ll, ll>& a, pair<ll, ll>& b)
{
	if (a.first != b.first) return a.first < b.first;
	else return a.second < b.second;
}

ll cal(pair<ll, ll> a, pair<ll, ll> b)
{
	return pow(a.first - b.first, 2) + pow(a.second - b.second, 2);
}

int main()
{
	ll n, a, b; cin >> n;
	while (n--)
	{
		vector<pair<ll, ll>> v;
		for (int i = 0; i < 4;i++)
		{
			cin >> a >> b;
			v.push_back(make_pair(a, b));
		}
		sort(v.begin(), v.end(), cmp);

		//for (auto a : v)
		//	cout << a.first << ' ' << a.second << endl;
		int a = cal(v[0], v[1]);
		int b = cal(v[0], v[2]);
		int c = cal(v[1], v[3]);
		int d = cal(v[2], v[3]);
		int e = cal(v[0], v[3]);
		int f = cal(v[1], v[2]);

		if (a == b && b == c && c == d && e == f)
			cout << 1 << endl;
		else cout << 0 << endl;
	}

	return 0;
}

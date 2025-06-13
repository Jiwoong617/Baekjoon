#include <iostream>
#include <map>

using namespace std;

int main()
{
	int n, a, b, ans = 0; cin >> n;
	map<int, int> m;
	for (int i = 0; i < n; i++)
	{
		cin >> a >> b;
		m.insert(make_pair(a, b));
	}

	int l = m.begin()->first, lm = m.begin()->second;
	int r = m.rbegin()->first, rm = m.rbegin()->second;
	for (auto a : m)
	{
		if (lm > a.second) continue;

		ans += (a.first - l) * lm;
		l = a.first;
		lm = a.second;
	}

	for (auto i = m.rbegin(); i != m.rend(); i++)
	{
		if (rm < i->second)
		{
			ans += (r - i->first) * rm;
			r = i->first;
			rm = i->second;
		}
	}

	cout << ans + lm;
	return 0;
}

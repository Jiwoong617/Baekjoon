#include <iostream>
#include <algorithm>
#include <map>
#include <vector>

using namespace std;

struct num
{
	int order = 0;
	int count = 0;
};

int main()
{
	int n, c, a; cin >> n >> c;

	map<int, num> m;
	for (int i = 0; i < n; i++)
	{
		cin >> a;
		if (m.find(a) != m.end())
			m[a].count++;
		else
			m[a] = { i, 1 };
	}

	vector<pair<int, num>> v(m.begin(), m.end());
	sort(v.begin(), v.end(), [](pair<int, num>& a, pair<int, num>& b)
		{
			if (a.second.count != b.second.count)
				return a.second.count > b.second.count;

			return a.second.order < b.second.order;
		});

	for (auto i : v)
		for (int j = 0; j < i.second.count; j++)
			cout << i.first << ' ';

	return 0;
}

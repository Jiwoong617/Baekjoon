#include <iostream>
#include <map>
#include <vector>
#include <algorithm>

using namespace std;

struct choochun
{
	int cnt;
	int time;
};

bool cmp(const pair<int, choochun>& l, const pair<int, choochun>& r)
{
	if (l.second.cnt == r.second.cnt)
		return l.second.time > r.second.time;
	else
		return l.second.cnt > r.second.cnt;
}

int main()
{
	int n, t, a; cin >> n >> t;
	map<int, choochun> m;
	vector<pair<int, choochun>> v;

	for (int i = 0; i < t; i++)
	{
		cin >> a;
		if (m.size() == n)
		{
			if (m.find(a) == m.end())
			{
				v = vector<pair<int, choochun>>(m.begin(), m.end());
				sort(v.begin(), v.end(), cmp);

				v.pop_back();
				m = map<int, choochun>(v.begin(), v.end());
				m.insert(make_pair(a, choochun{ 1, i }));
			}
			else
			{
				m[a].cnt++;
			}

		}
		else
		{
			if (m.find(a) != m.end())
				m[a].cnt++;
			else
				m.insert(make_pair(a, choochun{ 1, i }));
		}
	}

	for (auto a : m)
		cout << a.first << ' ';
	return 0;
}

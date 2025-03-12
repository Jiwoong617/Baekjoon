#include <algorithm>
#include <iostream>
#include <vector>
#include <queue>
using namespace std;

int n, w, l, a, ans = 0;
queue<int> t;
deque<pair<int, int>> b; //queue 는 iterator가 아님

int main()
{
	cin >> n >> w >> l;
	for (int i = 0;i < n; i++)
	{
		cin >> a;
		t.push(a);
	}

	while (!t.empty() || !b.empty())
	{
		for (int i = 0; i < b.size(); i++)
			b[i].second += 1;

		if (b.size() > 0)
		{
			if (b.front().second == w) b.pop_front();
		}

		int heavy = 0;
		for (auto h : b) heavy += h.first;
		if (t.size() > 0)
		{
			if (heavy + t.front() <= l && b.size() < w)
			{
				b.push_back(make_pair(t.front(), 0));
				t.pop();
			}
		}

		ans++;
	}

	cout << ans;
	return 0;
}

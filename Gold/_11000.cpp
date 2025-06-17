#include <iostream>
#include <queue>
#include <algorithm>

using namespace std;

int main()
{
	int n, s, t; cin >> n;
	vector<pair<int, int>> v;
	priority_queue<int> q;
	for (int i = 0; i < n; i++)
	{
		cin >> s >> t;
		v.push_back(make_pair(s, t));
	}
	sort(v.begin(), v.end());

	q.push(-v[0].second);
	for (int i = 1; i < n; i++)
	{
		q.push(-v[i].second);
		if (-q.top() <= v[i].first)
			q.pop();
	}

	cout << q.size();
	return 0;
}

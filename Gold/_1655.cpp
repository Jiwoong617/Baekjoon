#include <iostream>
#include <queue>
#include <functional>

using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int n, a; cin >> n;
	priority_queue<int> maxh;
	priority_queue<int, vector<int>, greater<int>> minh;

	while (n--)
	{
		cin >> a;
		if (maxh.size() <= minh.size()) maxh.push(a);
		else minh.push(a);

		if (minh.empty())
		{
			cout << maxh.top() << '\n';
			continue;
		}

		int maxtop = maxh.top();
		int mintop = minh.top();
		if (maxtop > mintop)
		{
			maxh.pop();
			minh.pop();
			maxh.push(mintop);
			minh.push(maxtop);
		}

		cout << maxh.top() << '\n';
	}

	return 0;
}

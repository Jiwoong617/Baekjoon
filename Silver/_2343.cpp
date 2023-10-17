#include <numeric>
#include <algorithm>
#include <vector>
#include <iostream>
using namespace std;

int n, m;
vector<int> v;
int bluerayCount(int len)
{
	int sum = 0, count = 0;
	for (int i = 0; i < n; i++)
	{
		sum += v[i];
		if (sum > len)
		{
			count++;
			sum = v[i];
		}
	}
	return sum == 0 ? count : count + 1;
}

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	cin >> n >> m;
	for (int i = 0; i < n; i++)
	{
		int a; cin >> a;
		v.push_back(a);
	}

	int l = *max_element(v.begin(), v.end());
	int r = accumulate(v.begin(), v.end(), 0);
	while (l <= r)
	{
		int mid = (l + r) / 2;
		int count = bluerayCount(mid);

		if (count <= m)
			r = mid - 1;
		else
			l = mid + 1;
	}
	cout << l;
}

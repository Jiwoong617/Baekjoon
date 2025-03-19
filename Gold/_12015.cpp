#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int n, t;
vector<int> v, ans;

int main()
{
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cin >> t;
		v.push_back(t);
	}

	ans.push_back(v[0]);
	for (int i = 1; i < n; i++)
	{
		if (v[i] > ans.back()) ans.push_back(v[i]);
		else
		{
			int idx = lower_bound(ans.begin(), ans.end(), v[i]) - ans.begin();
			ans[idx] = v[i];
		}
	}

	cout << ans.size();
	return 0;
}

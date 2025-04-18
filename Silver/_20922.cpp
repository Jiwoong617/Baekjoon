#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int n, k, ans = 0;
vector<int> v, cnt;

int main()
{
	cin >> n >> k;
	v = vector<int>(n, 0);
	cnt = vector<int>(100000, 0);
	for (int i = 0; i < n; i++)
		cin >> v[i];

	int l = 0, r = 0;
	while(r < n)
	{
		if (cnt[v[r]] < k)
		{
			cnt[v[r]]++;
			r++;
		}
		else
		{
			cnt[v[l]]--;
			l++;
		}

		ans = max(ans, r - l);
	}

	cout << ans;

	return 0;
}

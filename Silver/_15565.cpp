#include <iostream>
#include <vector>
#include <climits>

using namespace std;

int main()
{
	int n, k, ans = INT_MAX;
	int* cnt = new int[3]();
	cin >> n >> k;
	vector<int> v = vector<int>(n, 0);
	for (int i = 0; i < n; i++)
		cin >> v[i];

	int l = 0, r = 0;
	while (l < n)
	{
		if (cnt[1] < k)
		{
			if (r >= n) break;
			cnt[v[r]]++;
			r++;
		}
		else
		{
			cnt[v[l]]--;
			ans = min(ans, r - l);
			l++;
		}
	}

	cout << (ans == INT_MAX ? -1 : ans);

	return 0;
}

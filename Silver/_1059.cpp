#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int l, n, ans = 0;
	cin >> l;
	vector<int> v = vector<int>(l, 0);
	for (int i = 0; i < l; i++)
		cin >> v[i];
	cin >> n;
	sort(v.begin(), v.end());

	int idx = lower_bound(v.begin(), v.end(), n) - v.begin();
	if (v[idx] == n)
	{
		cout << 0;
		return 0;
	}
	
	int m = (idx == 0 ? 1 : v[idx - 1] + 1);
	for (int i = m; i <= n; i++)
		ans += (v[idx] - n);

	cout << ans - 1;
	return 0;
}

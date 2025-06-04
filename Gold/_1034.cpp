#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	int n, m, k; cin >> n >> m;
	string* s = new string[n];
	int* ans = new int[n]();
	for (int i = 0; i < n; i++)
		cin >> s[i];

	cin >> k;
	for (int i = 0; i < n; i++)
	{
		int cnt = count(s[i].begin(), s[i].end(), '0');

		if (cnt > k) continue;

		if (k % 2 == cnt % 2)
			ans[i] = count(s, s + n, s[i]);
	}

	cout << *max_element(ans, ans + n);
	return 0;
}

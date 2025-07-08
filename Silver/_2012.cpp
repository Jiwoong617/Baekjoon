#include <iostream>
#include <algorithm>
#include <cmath>

using namespace std;

int main()
{
	long long n, ans = 0; cin >> n;
	long long* a = new long long[n];
	for (int i = 0; i < n; i++)
		cin >> a[i];
	
	sort(a, a + n);
	for (int i = 0; i < n; i++)
		ans += abs(i + 1 - a[i]);
	cout << ans;
	return 0;
}

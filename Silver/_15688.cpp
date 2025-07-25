#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n; cin >> n;
	int* a = new int[n];
	for (int i = 0; i < n; i++)
		cin >> a[i];

	sort(a, a + n);
	for (int i = 0; i < n; i++)
		cout << a[i] << '\n';
	return 0;
}

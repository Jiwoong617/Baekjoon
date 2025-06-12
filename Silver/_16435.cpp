#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	int n, l; cin >> n >> l;
	int* h = new int[n];
	for (int i = 0; i < n; i++)
		cin >> h[i];
	sort(h, h + n);

	for (int i = 0; i < n; i++)
	{
		if (l < h[i]) break;
		l++;
	}

	cout << l;
	return 0;
}

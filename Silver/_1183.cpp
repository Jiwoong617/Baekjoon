#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	int n, a, b; cin >> n;
	int* arr = new int[n];
	for (int i = 0; i < n; i++)
	{
		cin >> a >> b;
		arr[i] = b - a;
	}
	sort(arr, arr + n);

	cout << (n % 2 == 1 ? 1 : arr[n / 2] - arr[n / 2 - 1] + 1);

	return 0;
}

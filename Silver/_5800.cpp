#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	int k, n; cin >> k;
	for (int i = 1; i <= k; i++)
	{
		cin >> n;
		int* arr = new int[n];
		int gap = 0;
		for (int i = 0; i < n; i++)
			cin >> arr[i];
		sort(arr, arr + n);

		for (int j = 0; j < n - 1; j++)
			gap = max(gap, arr[j + 1] - arr[j]);

		cout << "Class " << i << '\n';
		cout << "Max " << arr[n - 1] << ", ";
		cout << "Min " << arr[0] << ", ";
		cout << "Largest gap " << gap << "\n";
	}
}

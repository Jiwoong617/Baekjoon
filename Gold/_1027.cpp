#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	int n; cin >> n;
	int* arr = new int[n];
	int* cnt = new int[n]();
	for (int i = 0; i < n; i++)
		cin >> arr[i];

	for (int i = 0; i < n; i++)
	{
		double h = -1000000000;
		for (int j = i + 1; j < n; j++)
		{
			//float 값 초과
			double h2 = (double)(arr[j] - arr[i]) / (j - i);
			if (h2 > h)
			{
				h = h2;
				cnt[i]++;
				cnt[j]++;
			}
		}
	}
	
	cout << *max_element(cnt, cnt + n);
	return 0;
}

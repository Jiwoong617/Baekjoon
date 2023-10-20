#include <iostream>
using namespace std;

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n;
	cin >> n;
	int* arr = new int[n];
	int* line = new int[n] { 0, };
	for (int i = 0; i < n; i++)
		cin >> arr[i];

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (arr[i] == 0 && line[j] == 0) { line[j] = i+1; break; }
			else if (line[j] == 0) arr[i]--;
		}
	}
	for (int i = 0; i < n; i++)
		cout << line[i] << ' ';
}

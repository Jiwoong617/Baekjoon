#include <string>
#include <iostream>
using namespace std;

int arr[100001];
int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	string s;
	cin >> s;

	arr[0] = 1;
	for (int i = 1; i < s.length(); i++)
		arr[i] = arr[i - 1] * 2 % 1000000007;

	unsigned long long sum = 0;
	for (int i = 0; i < s.length(); i++)
	{
		if (s[i] == 'O')
		{
			sum += arr[i];
			sum %= 1000000007;
		}
	}
	cout << sum;
}

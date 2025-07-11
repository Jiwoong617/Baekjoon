#include <iostream>
#include <cmath>
#include <stack>

using namespace std;

int main()
{
	int a, b, n; cin >> a >> b >> n;
	stack<int> s;

	int ten = 0;
	while (n--)
	{
		int num; cin >> num;
		ten += num * pow(a, n);
	}

	while (ten)
	{
		int num = ten % b;
		ten /= b;
		s.push(num);
	}

	while (!s.empty())
	{
		cout << s.top() << ' ';
		s.pop();
	}
	return 0;
}

#include <string>
#include <iostream>
#include <stack>
using namespace std;
int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n;
	string s;
	cin >> n >> s;
	double* val = new double[n];
	for (int i = 0; i < n; i++)
		cin >> val[i];

	stack<double> stack;
	for (int i = 0; i < s.length(); i++)
	{
		if (s[i] > 64 && s[i] < 91)
			stack.push(val[s[i]-65]);
		else
		{
			double b = stack.top(); stack.pop();
			double a = stack.top(); stack.pop();
			switch (s[i])
			{
				case '+':
					a += b;
					break;
				case '-':
					a -= b;
					break;
				case '*':
					a *= b;
					break;
				case '/':
					a /= b;
					break;
			}
			stack.push(a);
		}
	}
	
	cout << fixed;
	cout.precision(2);
	cout << stack.top();
}

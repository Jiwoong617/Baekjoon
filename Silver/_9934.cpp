#include <iostream>
#include <vector>

using namespace std;

int n;
vector<int> input;
vector<int> tree[10];

void makeTree(int l, int r, int deep)
{
	if (n == deep || l >= r) return;

	int m = (l + r) / 2;
	tree[deep].push_back(input[m]);

	makeTree(l, m, deep + 1);
	makeTree(m + 1, r, deep + 1);
}

int main()
{
	cin >> n;
	int a;
	while (cin >> a)
		input.push_back(a);

	makeTree(0, input.size(), 0);

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < tree[i].size(); j++)
			cout << tree[i][j] << ' ';
		cout << '\n';
	}

	return 0;
}

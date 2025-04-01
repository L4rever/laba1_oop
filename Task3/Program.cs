using Task3;

TreeNode root = new TreeNode("Корень");

TreeNode child1 = new TreeNode("Потомок 1");
TreeNode child2 = new TreeNode("Потомок 2");

TreeNode grandChild1 = new TreeNode("Внук 1.1");
TreeNode grandChild2 = new TreeNode("Внук 1.2");
TreeNode grandChild3 = new TreeNode("Внук 2.1");

child1.AddChild(grandChild1);
child1.AddChild(grandChild2);
child2.AddChild(grandChild3);

root.AddChild(child1);
root.AddChild(child2);

Console.WriteLine("Структура дерева:");
root.PrintAllValues();
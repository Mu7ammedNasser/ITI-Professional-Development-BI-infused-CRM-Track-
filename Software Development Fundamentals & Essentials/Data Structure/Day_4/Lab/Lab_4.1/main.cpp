#include <iostream>

using namespace std;
class ListNode
{
public:
    int id ;
    ListNode* next;

    ListNode(int _id)
    {
        id = _id;
        next = nullptr;
    }
};
class Employee
{
private:
    int Id;

public:
    Employee* left;
    Employee* right;
    Employee(int new_Id)
    {
        Id = new_Id;
        left = nullptr;
        right = nullptr;
    }

    int getId()
    {
        return Id;
    }
    void setId(int _id)
    {
        this->Id = _id;
    }
};

class BinaryTree
{
private:
    Employee* pParent;
    Employee* Insert(Employee* pRoot , Employee* data);
    void inOrder(Employee* pRoot);
    void preOrder(Employee* pRoot);
    void postOrder(Employee* pRoot);
    Employee* SearchD( Employee* pRoot ,int wantedID);
    Employee* maxOfLeft(Employee* pRoot);
    Employee* DeleteD(Employee* pRoot , int IdOfNodeWantedDeletion);
    int heightOfTreeD(Employee* pRoot);
    bool isLinkedListPathInBinaryTreeD(Employee* root , ListNode* head);


public:
    BinaryTree()
    {
        pParent = nullptr;
    }
    void insertNode(int new_Id);
    void inOrderTraverse();
    void postOrderTraverse();
    void preOrderTraverse();
    Employee* Search(int wantedID);
    void Delete(int IdOfNodeWantDeletion);
    int heightOfTree();
    bool isLinkedListPathInBinaryTree(ListNode* head);

};

void BinaryTree::insertNode(int new_Id)
{
    Employee* data = new Employee(new_Id);
    pParent = Insert(pParent , data);
}

Employee* BinaryTree::Insert(Employee* pRoot , Employee* data)
{
    if(pRoot == nullptr)
    {
        return data;
    }
    else
    {
        if(data->getId() <= pRoot->getId())
        {
            pRoot->left = Insert(pRoot->left , data);
            return pRoot;
        }
        else
        {
            pRoot->right = Insert(pRoot->right , data);
            return pRoot;
        }
    }
}

void BinaryTree::inOrder(Employee* pRoot)
{
    if(!pRoot)
    {
        return;
    }
    inOrder(pRoot->left);
    cout<<pRoot->getId()<<endl;
    inOrder(pRoot->right);
}

void BinaryTree::preOrder(Employee* pRoot)
{
    if(!pRoot)
    {
        return;
    }
    cout<<pRoot->getId()<<endl;
    preOrder(pRoot->left);
    preOrder(pRoot->right);
}

void BinaryTree::postOrder(Employee* pRoot)
{
    if(!pRoot)
    {
        return;
    }
    postOrder(pRoot->left);
    postOrder(pRoot->right);
    cout<<pRoot->getId()<<endl;
}

void BinaryTree::inOrderTraverse()
{
    BinaryTree::inOrder(pParent);
}

void BinaryTree::preOrderTraverse()
{
    BinaryTree::preOrder(pParent);
}

void BinaryTree::postOrderTraverse()
{
    BinaryTree::postOrder(pParent);
}


Employee* BinaryTree::SearchD( Employee* pRoot ,int wantedID)
{

    if(pRoot == nullptr)
        return nullptr;
    else if(wantedID == pRoot->getId())
        return pRoot;
    else if(wantedID < pRoot->getId())
    {
        return SearchD(pRoot->left , wantedID);
    }
    else
    {
        return SearchD(pRoot->right , wantedID);
    }

}

Employee* BinaryTree::Search(int wantedId)
{
    return BinaryTree::SearchD(pParent , wantedId);
}

Employee* BinaryTree::DeleteD(Employee* pRoot , int IdOfNodeWantedDeletion)
{
    //cout<<"value of current parent"<<pRoot->getId()<<endl;
    if(pRoot == nullptr)
        return nullptr;
    if(pRoot->getId()> IdOfNodeWantedDeletion)
    {
        pRoot-> left = DeleteD(pRoot->left ,  IdOfNodeWantedDeletion);
        return pRoot;
    }
    else if(pRoot->getId()<IdOfNodeWantedDeletion)
    {
        pRoot->right = DeleteD(pRoot->right , IdOfNodeWantedDeletion);
        return pRoot;
    }
    else
    {
        if(pRoot->left == nullptr && pRoot->right ==nullptr)
        {
            delete pRoot;
            return nullptr;
        }
        else if(pRoot->left == nullptr)
        {
            Employee* temp = pRoot->right;
            // here how i can reach to the parent of pRoot to make it's left node equal the right of pRoot
            delete pRoot;
            return temp;
        }
        else if(pRoot->right == nullptr)
        {
            Employee* temp = pRoot->left;
            // here how i can reach to the parent of pRoot to make it's left node equal the right of pRoot
            delete pRoot;
            return temp;
        }
        else
        {
            Employee* temp = maxOfLeft(pRoot->left);
            pRoot->setId(temp->getId());
            pRoot->left = DeleteD(pRoot->left, temp->getId());
            return pRoot;
        }
    }

}

Employee* BinaryTree::maxOfLeft(Employee* pRoot)
{
    if(pRoot == nullptr)
        return nullptr;
    if(pRoot->right == nullptr)
    {
        return pRoot;
    }
    return maxOfLeft(pRoot->right);
}

void BinaryTree::Delete(int IdOfNodeWantedDeletion)
{
    BinaryTree::DeleteD(pParent , IdOfNodeWantedDeletion);
    return;
}

int BinaryTree::heightOfTreeD(Employee* pRoot)          //Root = 12
{
    if(pRoot == nullptr)
        return -1;
    int leftH = heightOfTreeD(pRoot->left);//1
    int rightH = heightOfTreeD(pRoot->right);//0

    return 1 + max(leftH , rightH);
}

int BinaryTree::heightOfTree()
{
    return BinaryTree::heightOfTreeD(pParent);
}

bool matchPath(Employee* treeNode, ListNode* listNode) {
    if (listNode == nullptr)
        return true;

    if (treeNode == nullptr)
        return false;

    if (treeNode->getId() != listNode->id)
        return false;

    return matchPath(treeNode->left, listNode->next) ||
           matchPath(treeNode->right, listNode->next);
}

bool BinaryTree::isLinkedListPathInBinaryTreeD(Employee* root , ListNode* head)
{
    if (root == nullptr)
        return false;

    if (matchPath(root, head))
        return true;

    return isLinkedListPathInBinaryTreeD(root->left, head) ||
           isLinkedListPathInBinaryTreeD(root->right, head);
}


bool BinaryTree::isLinkedListPathInBinaryTree(ListNode* head)
{
    return BinaryTree::isLinkedListPathInBinaryTreeD(pParent , head);
}


int main()
{

    BinaryTree* B1 = new BinaryTree();

    B1->insertNode(12);
    B1->insertNode(65);
    B1->insertNode(5);
    B1->insertNode(2);
    B1->insertNode(6);
    B1->insertNode(1);
    B1->insertNode(3);

    ListNode* head = new ListNode(5);
    head->next = new ListNode(5);
    head->next->next = new ListNode(1);

    if(B1->isLinkedListPathInBinaryTree(head))
        cout<<"linked list of employee exist as downwards path in tree"<<endl;
    else
        cout<<"linked list not exist in tree as  downwards path"<<endl;




    return 0;
}

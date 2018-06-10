#include <windows.h>
#include"resources.h"
LRESULT CALLBACK WindowProcedure (HWND, UINT, WPARAM, LPARAM);

void AddMenu(HWND);
void DialogClass(HINSTANCE);
void DisplayDialog(HWND);
void DrawCol(int, HWND);

HMENU hMenu;
HFONT hfont= NULL;
HWND hwndW,listBox, buttonAdd, addBox, scrollColor,scrollWidth, scrollHeight;

int xID;
WNDPROC OldScroll ;
char szClassName[ ] = "CodeBlocksWindowsApp";

int WINAPI WinMain (HINSTANCE hThisInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR lpszArgument,
                     int nCmdShow)
{
    HWND hwnd;
    MSG messages;
    WNDCLASSEX wincl;
    wincl.hInstance = hThisInstance;
    wincl.lpszClassName = szClassName;
    wincl.lpfnWndProc = WindowProcedure;
    wincl.style = CS_DBLCLKS;
    wincl.cbSize = sizeof (WNDCLASSEX);
    wincl.hIcon = LoadIcon (hThisInstance, MAKEINTRESOURCE(ID_ICON));
    wincl.hIconSm = LoadIcon (hThisInstance, MAKEINTRESOURCE(ID_ICON));
    wincl.hCursor = LoadCursor (NULL, IDC_ARROW);
    wincl.lpszMenuName = NULL;
    wincl.cbClsExtra = 0;
    wincl.cbWndExtra = 0;
    wincl.hbrBackground = (HBRUSH) COLOR_BACKGROUND;
    if (!RegisterClassEx (&wincl))
        return 0;
    DialogClass(hThisInstance);

    hwndW = CreateWindowEx (
           0,
           szClassName,
           "Second Laboratory Work",
           WS_OVERLAPPEDWINDOW,
           CW_USEDEFAULT,
           CW_USEDEFAULT,
           544,
           375,
           HWND_DESKTOP,
           NULL,
           hThisInstance,
           NULL
           );
    ShowWindow (hwndW, nCmdShow);
    while (GetMessage (&messages, NULL, 0, 0))
    {
        TranslateMessage(&messages);
        DispatchMessage(&messages);
    }

    return messages.wParam;
}


LRESULT CALLBACK WindowProcedure (HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    LRESULT textSize;

    char textStore[20];
    HINSTANCE hInstance ;
    int i, cxWP, cyWP ;
    switch (message)
    {
        case WM_CREATE:
        {
            AddMenu(hwnd);
            addBox = CreateWindowEx(WS_EX_CLIENTEDGE, TEXT("EDIT"), TEXT(""),
                         WS_VISIBLE | WS_CHILD,
                         100, 10, 150, 25,
                         hwnd, (HMENU)ID_ADDBOX, GetModuleHandle(NULL), NULL);
            buttonAdd = CreateWindowEx(NULL, TEXT("BUTTON"), TEXT("Add"),
                         WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,
                         260, 10, 60, 25,
                         hwnd, (HMENU) ID_ADD, GetModuleHandle(NULL), NULL);
            listBox = CreateWindowEx(WS_EX_CLIENTEDGE, TEXT("LISTBOX"), TEXT(""),
                            WS_VISIBLE | WS_CHILD | LBS_NOTIFY,
                            100, 45, 150, 200,
                            hwnd, (HMENU) ID_LISTBOX, GetModuleHandle(NULL), NULL );
            scrollColor = CreateWindowEx(NULL, TEXT("SCROLLBAR"), TEXT(""),
                             WS_VISIBLE | WS_CHILD | SBS_HORZ,
                             260, 45, 220, 25,
                             hwnd, (HMENU)ID_SCROLL_COLOR, GetModuleHandle(NULL), NULL);
            SendMessage(addBox, EM_LIMITTEXT, WPARAM(10), NULL);
            xID = 0;
            SetScrollRange(scrollColor, SB_CTL, 0, 255, FALSE);
            SetScrollPos(scrollColor, SB_CTL, xID, TRUE);
            SetFocus(scrollColor);
            hInstance = (HINSTANCE) GetWindowLong (hwnd, GWL_HINSTANCE) ;
            break;

        }
        case WM_CONTEXTMENU:
        {
            if ((HWND)wParam == listBox)
            {
                if(MessageBox(hwnd, "Remove this item?", "Alert", MB_YESNO) == IDYES)
                {
                    int index = SendMessage(GetDlgItem(hwnd, ID_LISTBOX), LB_GETCURSEL, 0, 0);
                    SendMessage(GetDlgItem(hwnd, ID_LISTBOX), LB_DELETESTRING, index, 0);
                }
                break;
            }
            break;
        }
        case WM_COMMAND:
        {
            switch(wParam)
            {
                case FILE_SOUND:
                {
                    MessageBeep(MB_OK);
                    break;
                }

                case FILE_DBOX:
                {
                    DisplayDialog(hwnd);
                    MessageBeep(MB_OK);
                    break;
                }

                case FILE_EXIT:
                {
                    DestroyWindow(hwnd);
                    break;
                }

                case ID_ADD:
                {
                    textSize = SendMessage(addBox, WM_GETTEXT, 100, (LPARAM)textStore);
                    textStore[textSize] = ('\0');
                    SendMessage(listBox, LB_ADDSTRING, 0, (LPARAM)textStore);
                    RedrawWindow(hwnd, NULL, NULL, RDW_INVALIDATE | RDW_ERASE);
                    SendMessage(addBox, WM_SETTEXT, NULL, NULL);
                    break;
                }
            }
            break;
        }
        case WM_SIZE:
        {
            cxWP = LOWORD(lParam);
            cyWP = HIWORD(lParam);
            MoveWindow(addBox, cxWP/18, cyWP/20, (cxWP - cxWP/12 - 3*cxWP/18), cyWP/15, TRUE);
            MoveWindow(buttonAdd, (cxWP - cxWP/12 - cxWP/18), cyWP/20, (cxWP/12), cyWP/15, TRUE);
            MoveWindow(listBox, cxWP/18, (2*cyWP/20 + cyWP/15), (cxWP - 2*cxWP/18), (cyWP - 3*cyWP/20 - 2*cyWP/15), TRUE);
            MoveWindow(scrollColor, cxWP/18, (cyWP - cyWP/20 - cyWP/15), (cxWP - 2*cxWP/18), cyWP/15, TRUE);
            break;
        }
        case WM_GETMINMAXINFO:
        {
            LPMINMAXINFO lp = (LPMINMAXINFO)lParam;
            lp->ptMinTrackSize.x = 500;
            lp->ptMinTrackSize.y = 400;
            lp->ptMaxTrackSize.x = 700;
            lp->ptMaxTrackSize.y = 500;
            break;
        }
        case WM_HSCROLL:
        {
            switch(LOWORD(wParam))
            {
                case SB_LINELEFT:
                {
                    xID -= 50;
                    DrawCol(xID, hwnd);
                    break;
                }

                case SB_LINERIGHT:
                {
                    xID += 50;
                    DrawCol(xID, hwnd);
                    break;
                }

                case SB_PAGELEFT:
                {
                    xID -= 50;
                    DrawCol(xID, hwnd);
                    break;
                }

                case SB_PAGERIGHT:
                {
                    xID += 50;
                    DrawCol(xID, hwnd);
                    break;
                }

                case SB_THUMBPOSITION:
                {
                    DrawCol(xID, hwnd);
                    break;
                }

                case SB_TOP:
                {
                    xID = 0;
                    DrawCol(xID, hwnd);
                    break;
                }

                case SB_BOTTOM:
                {
                    xID = 255;
                    DrawCol(xID, hwnd);
                    break;
                }

                case SB_THUMBTRACK:
                {
                    xID = HIWORD(wParam);
                    DrawCol(xID, hwnd);
                    break;
                }

                default: break;
            }
            SetScrollPos(scrollColor, SB_CTL, xID, TRUE);
            if(xID == 255)
            {
                DrawCol(xID-1, hwnd);
                EnableScrollBar(scrollColor, SB_CTL, ESB_DISABLE_RIGHT);
            }
            if(xID == 0)
            {
                DrawCol(xID+1, hwnd);
                EnableScrollBar(scrollColor, SB_CTL, ESB_DISABLE_LEFT);
            }
            InvalidateRect(addBox, NULL, TRUE);
            break;
        }
        case WM_CTLCOLOREDIT:
        {
            SetBkMode((HDC)wParam, RGB(122, 122, 122));
            HBRUSH locBrush=(HBRUSH)CreateSolidBrush(RGB(255, 255, 255));
            return(LRESULT) locBrush;
        }
        case WM_SETFOCUS:
        {
            SetFocus(scrollColor);
            break;
        }
        case WM_DESTROY:
            PostQuitMessage (0);
            break;
        default:
            return DefWindowProc (hwnd, message, wParam, lParam);
    }

    return 0;
}

void AddMenu(HWND hwnd)
{
    hMenu = CreateMenu();
    AppendMenu(hMenu,MF_STRING,FILE_SOUND,"Sound");
    AppendMenu(hMenu,MF_STRING,FILE_DBOX,"DialogBox");
    AppendMenu(hMenu,MF_STRING,FILE_EXIT,"Exit");
    SetMenu(hwnd,hMenu);
}
LRESULT CALLBACK DialogProcedure (HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
     switch (message)
    {
        case WM_CLOSE:
            EnableWindow(hwndW,true);
            DestroyWindow(hwnd);
            break;
        default:
            return DefWindowProc (hwnd, message, wParam, lParam);
    }

    return 0;
}

void DialogClass(HINSTANCE hThisInstance)
{
    WNDCLASSEX dialog ;
    char szClassName[ ] = "myDialogClass";
    dialog.hInstance = hThisInstance;
    dialog.lpszClassName = szClassName;
    dialog.lpfnWndProc = DialogProcedure;
    dialog.style = CS_DBLCLKS;
    dialog.cbSize = sizeof (WNDCLASSEX);
    dialog.hIcon = LoadIcon (NULL, IDI_APPLICATION);
    dialog.hIconSm = LoadIcon (NULL, IDI_APPLICATION);
    dialog.hCursor = LoadCursor (NULL, IDC_HAND);
    dialog.lpszMenuName = NULL;
    dialog.cbClsExtra = 0;
    dialog.cbWndExtra = 0;
    dialog.hbrBackground = (HBRUSH) COLOR_BACKGROUND;
    RegisterClassEx (&dialog);
}

void DisplayDialog(HWND hwnd)
{
    HWND hDlg = CreateWindowW(L"myDialogClass",L"DialogBox",WS_VISIBLE| WS_OVERLAPPEDWINDOW, 400,400,
                  300,200,hwnd, NULL,NULL,NULL);
    RECT rect;
    PAINTSTRUCT paintstruct;
    char center[]="This is a Dialog Box";
    HDC hdc = BeginPaint(hDlg, &paintstruct);
    GetClientRect(hDlg, &rect);
    SetBkMode(hdc,TRANSPARENT);
    DrawText(hdc, center, -1, &rect, DT_WORDBREAK | DT_CENTER |DT_SINGLELINE |DT_VCENTER);
    HFONT hfo = (HFONT)SelectObject(hdc, hfont);
    SelectObject(hdc,hfo);
    EndPaint(hDlg, &paintstruct);
    EnableWindow(hwnd,false);
}
void DrawCol( int xID, HWND hwnd)
{
	PAINTSTRUCT ps;
	HDC hdc = BeginPaint(hwnd, &ps);
    SetClassLong(hwnd, GCL_HBRBACKGROUND, (LONG)CreateSolidBrush(RGB(122, xID, 122)));
	InvalidateRect(hwnd, NULL, TRUE);
	EndPaint(hwnd, &ps);
}

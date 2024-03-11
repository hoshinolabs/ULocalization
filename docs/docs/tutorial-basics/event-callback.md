---
sidebar_position: 5
---

# Event Callback

言語の切り替えやローカライズの再処理などが発生したときに処理を呼び出すことができます。  
デフォルトではテキストでは `Text.text` や `TextMeshProUGUI.text` などのプロパティに値をセットするように設定されています。  
他のコンポーネントの処理を呼び出すことも簡単に行えます。  

### テキストを設定する

以下のようにテキストコンポーネントをセットし呼び出し対象に `text` プロパティを選択することでテキストを設定することができます。  
![](img/event-callback-01.png)

### ピックアップの接触テキストを設定する

以下のように設定すると触れようとした時のテキストを設定することができます。  
![](img/event-callback-02.png)

### Udon の処理を呼び出す

以下のように設定するとローカライズが実行されたときに任意の処理を実行することができます。  
言語変更などでローカライズが実行されると対象の Udon の `MethodName` メソッドが呼び出されます。  
![](img/event-callback-03.png)

または以下のようにローカライズテキストをメソッド名として処理を呼び出すこともできます。  
例では英語に変更されたときは `Method_En` メソッドが呼び出されます。  
同じように日本語に変更されたときに `Method_Ja` メソッドが呼び出されます。  
![](img/event-callback-04.png)

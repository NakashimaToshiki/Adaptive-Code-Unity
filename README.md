# Unityで適応性の高いコードを書く考察

自身の勉強も兼ねて、Unityを使ったデザインパターンに関するコードを作成していきます。

## この記事を書いている人のプログラミングレベル

プログラミンング歴６年目。得意の言語はC#
仕事でWinFormを使って業務アプリを作り、
趣味でUnityを使ってゲームを作っています。

## 有用な技術書

デザインパターンの書籍はたくさんありますが、言語をC#に絞ると以下の２つの書籍が有名かなと思います。

- [Adaptive Code](https://www.amazon.co.jp/Adaptive-Code-%E5%AE%9F%E8%B7%B5%E9%96%8B%E7%99%BA%E6%89%8B%E6%B3%95-%E7%AC%AC2%E7%89%88-%E3%83%9E%E3%82%A4%E3%82%AF%E3%83%AD%E3%82%BD%E3%83%95%E3%83%88%E9%96%A2%E9%80%A3%E6%9B%B8/dp/4822253546)
- [.NETのエンタープライズアプリケーションアーキテクチャ](https://www.amazon.co.jp/%EF%BC%8E%EF%BC%AE%EF%BC%A5%EF%BC%B4%E3%81%AE%E3%82%A8%E3%83%B3%E3%82%BF%E3%83%BC%E3%83%97%E3%83%A9%E3%82%A4%E3%82%BA%E3%82%A2%E3%83%97%E3%83%AA%E3%82%B1%E3%83%BC%E3%82%B7%E3%83%A7%E3%83%B3%E3%82%A2%E3%83%BC%E3%82%AD%E3%83%86%E3%82%AF%E3%83%81%E3%83%A3-%E7%AC%AC%EF%BC%92%E7%89%88-%E3%83%9E%E3%82%A4%E3%82%AF%E3%83%AD%E3%82%BD%E3%83%95%E3%83%88%E5%85%AC%E5%BC%8F%E8%A7%A3%E8%AA%AC%E6%9B%B8-Dino-Esposito/dp/4822298485)

基本的に書籍で説明に用いているプラットフォームはWPF,WinForm,asp.net MVCなので、内容をUnityで使う場合はどうなるのかを考察していきたいと思います。

## 便利なフレームワーク

以下のフレームワークを使ってサンプルを作成します。

- [UniRx](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)
- [Zenject](https://assetstore.unity.com/packages/tools/integration/zenject-dependency-injection-ioc-17758)

UniRxはUnityにはデータバインドがないので、ないと不便すぎるぐらいです。
Zenjectは依存性注入に関してはUnity標準のInspector上でコンポーネントをドラッグ&ドロップで代用できるので、
は果たして必要なのか？というのが今の所感です。

## ソースコード

有名なゲームSkyrimを題材にして
デザインパターンの練習をしますので、
最終的にはシンプルなアクションゲームとして公開できればと思っています。


# 图解设计模式 C# 实现

《图解设计模式》，【日】结城浩 著，杨文轩 译。

原书和翻译只给出了 Java 实现，本项目基于 C# 实现，本人没有学过 Java，但由于 Java 语法与 C# 如此相似，将其“翻译”为 C# 的过程中基本没有遇到什么障碍。

## 设计原则

设计原则|定义
:-:|:-
单一职责原则<br>(Single Responsibility Principle, SRP)|一个类只负责一个功能领域中的相应职责
开闭原子<br>(Open-Closed Principle, OCP)|软件实体应对扩展开放，而对修改关闭
里氏替换原则<br>(Liskov Substitution Principle, LSP)|**继承必须确保超类所拥有的性质在子类中仍然成立**
依赖倒转原则<br>(Despendence Inversion Principle, DIP)|抽象不应该依赖于细节，细节应该依赖于抽象
接口隔离原则<br>(Interface Segregation Principle, ISP)|使用多个专门接口，而不是使用单一的总接口
合成复用原则<br>(Composite Reuse Principle, CRP)|尽量使用对象组合，而不是继承来达到复用目的
迪米特法则<br>(Law of Demeter, LoD)|一个软件实体应尽可能少地与其他是否发生相互作用

## 设计模式

- <font color=green>Creational 创建者模式</font>
- <font color=dodgerBlue>*Structural 结构模式*</font>
- <font color=red>**Behavioral 行为模式**</font>

Pattern|模式|简介|定义
:-|:-|:-|:-
**1 适应设计模式**|
<font color=red>**Iterator**</font>|迭代器|一个一个遍历|提供一种方法来访问聚合对象，而不用暴露这个对象的内部表示。
<font color=dodgerBlue>*Adapter*</font>|适配器|加个“适配器”以便复用|将一个接口转换为客户希望的另一个接口，使接口不兼容的那些类可以一起工作。
**2 交给子类**|
<font color=red>**Template Method**</font>|模板方法|将具体处理交给子类|定义一个操作中算法的框架，而将一些步骤延迟到子类中，使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
<font color=green>Factory Method</font>|工厂方法|将实例的生成交给子类|父类决定实例的生成方式，但并不决定生成的具体的类，具体的处理交给子类负责。
**3 生成实例**|
<font color=green>Singleton</font>|单例|只有一个实例|确保该类只有一个实例，而且自行实例化并向整个系统提供这个实例。
<font color=green>Prototype</font>|原型|通过复制生成实例|使用原型的实例指定创建对象的种类，且通过复制这些原型创建新的对象。
<font color=green>Builder</font>|建造者|组装复杂实例|将一个复制对象的构建与他的表示分离，使得同样的构建过程可以创建同样的表示。*在Builder模式中Director角色控制Builder角色；在Template Method模式中父类控制子类。*
<font color=green>Abstract Factory</font>|抽象工厂|将关联的零件组装成产品|提供一个创建一系列相关或相互依赖对象的接口，而无需指定他们具体的类。
**4 分开考虑**|
<font color=dodgerBlue>*Bridge*</font>|桥接|将类的功能层次结构与实现层次结构分离|将抽象部分与其他实现部分分离，使他们都可以独立的变化。
<font color=red>**Strategy**</font>|策略|整体地替换算法|定义一系列算法的类，将每个算法封装起来，并让他们可以相互替换，使得算法的变化可以独立与他的客户。
**5 一致性**|
<font color=dodgerBlue>*Composite*</font>|组合|容器与内容的一致性|组合多个对象形成树形结构以表示具有“整体一部分”关系的层次结构。
<font color=dodgerBlue>*Decorator*</font>|装饰|装饰边框与被装饰物的一致性|外部与一个子系统的通信通过一个系统的外观对象进行，为子系统的一组接口提供一个一致的入口。
**6 访问数据结构**|
<font color=red>**Visitor**</font>|访问者|访问数据结构并处理数据|提供一个用于某对象结构中的各元素的操作表示，使得可以在不改变各元素的类的前提下定义与作用这些元素的新操作。
<font color=red>**Chain of Responsibility**</font>|职责链|推卸责任|避免将请求者与接收者耦合在一起，让多个对象都有机会接收请求，将这些对象连接成一条链，并且沿着这条链传递请求，直到有对象处理他为止。
**7 简单化**|
<font color=dodgerBlue>*Facade*</font>|外观|简化窗口|外部与一个子系统的通信通过一个统一的外观对象进行，为子系统的一组接口提供一个一致的入口。
<font color=red>**Mediator**</font>|中介者|只有一个仲裁者|用一个中介对象（中介者）来封装一系列对象交互，中介者使各对象不需要显式地相互交互，从而使耦合松散，而且可以独立地改变他们之间的交互。
**8 状态管理**|
<font color=red>**Observer**</font>|观察者|发送状态变化通知|定义对象之间的一种一对多依赖关系，使得当每个对象的状态发生改变时，其相应的依赖对象皆得到通知并被自动更新。
<font color=red>**Memento**</font>|备忘录|保存对象状态|在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样可以在以后将该对象恢复到原先保存的状态。
<font color=red>**State**</font>|状态|用类表示状态|允许一个对象在其内部状态改变时改变他的行为，其相关依赖对象皆得到通知并被自动更新。
**9 避免浪费**|
<font color=dodgerBlue>*FlyWeight*</font>|享元|共享对象避免浪费|运用共享技术有效地支持大量细粒度对象发复用。
<font color=dodgerBlue>*Proxy*</font>|代理|只在必要时生成实例|给某个对象提供一个代理，并有代理对象控制对原对象的引用。
**10 用类来表现**|
<font color=red>**Command**</font>|命令|命令也是类|将一个请求封装为一个对象，从而可用不同的请求对客户进行参数化，对请求排队或记录请求日志，以及支持可撤销的操作。
<font color=red>**Interpreter**</font>|解释器|预防规则也是类|定义一个语言的文法，并建立一个解释器来解释该语言中的句子。

*设计原则及模式的定义参考了《设计模式的艺术：软件开发人员内功修炼之道》，刘伟 著。*

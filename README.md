# NewTalents — Calculadora com TDD

Projeto em **C#** para praticar **desenvolvimento orientado a testes** com **xUnit**.

- `NewTalents/Calculadora.cs` — `somar`, `subtrair`, `multiplicar`, `dividir` e `historico`.
- `NewTalentsTest/UnitTest1.cs` — testes `[Theory]` para cada operação e um teste de divisão por zero.
- `pipeline.yml` — definição de pipeline de integração contínua.

> Ponto de partida do ciclo TDD: `somar` ainda devolve `0`, por isso o respetivo teste falha até ser implementado (vermelho → verde → refatorar).

```bash
dotnet test
```

# Desafios de Programação Personalizados - Análise Climática C#

## Análise Inicial do Projeto
- **Estrutura**: C# console para processamento CSV clima (ano,mes,temp,prec).
- **Versões**: V1 (God Class, duplicação), V2 (melhorada com statics/XML docs).
- **Nível**: Júnior - basics OK, falta DRY/SOLID/LINQ/validações.
- **Refatorações sugeridas**: Enums, interfaces IFilter, LINQ, parser robusto, Repository.

## Desafios Lógica (3)
### 1. Otimizar Loops Aninhados (Iniciante)
**Contexto**: V1 O(N²) lento.
**Objetivo**: Single pass contagem.
**Requisitos**: 1 loop, if Contains.
**Dicas**: meses.Contains + temp ==.
**Validação**: Tempo <50% original.

### 2. Validação CSV (Intermediário)
**Contexto**: Crash CSV inválido.
**Objetivo**: Try-catch + log erros.
**Requisitos**: Length==4, trim.
**Dicas**: Skip + count inválidos.
**Validação**: Linha ruim → continua.

### 3. Correlação Temp-Prec (Avançado)
**Contexto**: Ignora prec.
**Objetivo**: % Quente+muita por estação.
**Requisitos**: double %.
**Dicas**: Count / total *100.
**Validação**: Verão Quente ~60%.

## Desafios Modelagem (3)
### 4. Enums Record (Iniciante)
**Contexto**: Magic strings.
**Objetivo**: enum Temp {Quente,Frio,Ameno}.
**Requisitos**: Parse string→enum.
**Dicas**: Enum.Parse.
**Validação**: Output igual.

### 5. Strategy Filter (Interm)
**Contexto**: Filtros hard-coded.
**Objetivo**: IFiltro Aplicar(List).
**Requisitos**: Impl Temp/Estacao/Ano.
**Dicas**: private _temp.
**Validação**: Polimorfismo Main.

### 6. Repository (Avançado)
**Contexto**: IO espalhada.
**Objetivo**: IRepository GetAll/Filter.
**Requisitos**: CsvRepository.
**Dicas**: DI no Program.
**Validação**: Unit test mock.

## Regras Negócio (3)
### 7. Tendência Anual (Iniciante)
**Contexto**: Sem evolução tempo.
**Objetivo**: +% quente por ano.
**Requisitos**: Group ano.
**Dicas**: Nested count.
**Validação**: "Verão +20%".

### 8. Alertas (Interm)
**Contexto**: Sem regras real.
**Objetivo**: Seca/OndaCalor.
**Requisitos**: >3 seguidos.
**Dicas**: Order data scan.
**Validação**: 2+ alertas dados.csv.

### 9. JSON Relatório (Avançado)
**Contexto**: Console only.
**Objetivo**: Serialize contagens.
**Requisitos**: Text.Json + file.
**Dicas**: Record Relatorio.
**Validação**: JSON válido.

## Features Real (2)
### 10. CLI Menu (Interm)
**Contexto**: Hard-coded.
**Objetivo**: while switch input.
**Requisitos**: Valida opção.
**Dicas**: ReadLine switch.
**Validação**: Teste manual.

### 11. Multi-CSV Cache (Avançado)
**Contexto**: 1 arquivo.
**Objetivo**: Dict cache arquivos.
**Requisitos**: Compara cidades.
**Dicas**: !cache.ContainsKey.
**Validação**: 2 CSVs compara.

Implemente em ordem 1→11. Peça review!


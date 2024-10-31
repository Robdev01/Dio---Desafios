import json

# Carregar o faturamento diário a partir do arquivo JSON
with open('faturamento.json') as file:
    dados = json.load(file)

faturamento = [valor for valor in dados["faturamento_diario"] if valor > 0]

# Cálculos
menor_faturamento = min(faturamento)
maior_faturamento = max(faturamento)
media_mensal = sum(faturamento) / len(faturamento)
dias_acima_da_media = sum(1 for valor in faturamento if valor > media_mensal)

# Exibir os resultados
print(f"Menor faturamento: R${menor_faturamento}")
print(f"Maior faturamento: R${maior_faturamento}")
print(f"Número de dias com faturamento acima da média: {dias_acima_da_media}")

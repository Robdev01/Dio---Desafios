import pymongo

# Conectar ao MongoDB Atlas
client = pymongo.MongoClient("mongodb+srv://robsondev01:<password>@bank.nbdenyb.mongodb.net/?retryWrites=true&w=majority&appName=Bank")
db = client["meu_banco_de_dados"]  # Nome do banco de dados

# Definir a coleção 'bank' para armazenar os documentos de clientes
collection = db["bank"]

# Inserir documentos de clientes com a estrutura mencionada
for i in range(1, 11):
    cliente_doc = {
        "id": i,
        "nome": f"Pessoa {i}",
        "cpf": "000.000.000-0",
        "endereco": "Endereço da pessoa",
        "contas": [
            {
                "id_conta": i,
                "tipo": "Corrente",
                "agencia": "Agência X",
                "num": 1000 + i,
                "saldo": 1000
            }
        ]
    }
    collection.insert_one(cliente_doc)

# Recuperar informações com base nos pares de chave e valor
# Por exemplo, recuperar todos os documentos de clientes com CPF "000.000.000-0"
result = collection.find({"cpf": "000.000.000-0"})
for document in result:
    print(document)

# Ou recuperar todas as contas de um cliente específico pelo ID
result = collection.find_one({"id": 1})
contas = result["contas"]
for conta in contas:
    print(conta)

result = collection.find_one({"id": 1})
contas = result["contas"]
for conta in contas:
    
    print(conta)
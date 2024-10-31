from sqlalchemy.orm import declarative_base, sessionmaker
from sqlalchemy.orm import relationship
from sqlalchemy import Column, create_engine
from sqlalchemy import ForeignKey
from sqlalchemy import Integer
from sqlalchemy import String

Base = declarative_base()

class Conta(Base):
    __tablename__ = "conta"
    id = Column(Integer, primary_key= True)
    tipo = Column(String)
    agencia = Column(String)
    num = Column(Integer)
    id_cliente = Column(Integer, ForeignKey('cliente.id'))
    saldo = Column(Integer)

    cliente = relationship("Cliente", back_populates="contas")

class Cliente(Base):
    __tablename__ = "cliente"
    id = Column(Integer, primary_key= True)
    nome = Column(String)
    cpf = Column(String(11))
    endereco = Column(String)

    contas = relationship("Conta", back_populates="cliente")

# Configurar a conexão com o banco de dados
engine = create_engine('sqlite:///meu_banco_de_dados.db')
Session = sessionmaker(bind=engine)
session = Session()

# Criar tabelas se não existirem
Base.metadata.create_all(engine)

# Criar 10 pessoas
for i in range(1, 11):
    cliente = Cliente(nome=f"Pessoa {i}", cpf="000.000.000-0", endereco="Endereço da pessoa")
    session.add(cliente)


# Enviar os objetos para o banco de dados
session.commit()
 #Consulta 1: Obter todos os clientes
clientes = session.query(Cliente).all()
for cliente in clientes:
    print(f"ID: {cliente.id}, Nome: {cliente.nome}, CPF: {cliente.cpf}, Endereço: {cliente.endereco}")


# Fechar a sessão
session.close()
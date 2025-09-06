## CP1 - Advanced Business Development
RM559617 - Fernando Nachtigall Tessmann

### Domínio e entidades
O domínio escolhido foi de uma concessionária, mais específico uma parte de mecânica,
onde temos o cliente(Customer), o seu veículo(Car), o colaborador(Employee) dessa concessionária,
o serviço(ServiceAppointment) a ser realizado no veiculo e o orçamento(Quote) do serviço. 

### Relacionamento
Customer (1) -> Car (N): Um cliente pode ter vários carros;<br>
Car (1) -> ServiceAppointment (N): Um carro pode ter vários agendamentos;<br>
Employee (1) -> ServiceAppointment (N): Um funcionário pode atender vários agendamentos;<br>
Quote (1) -> ServiceAppointment (0..1): Um orçamento pode estar associado a um agendamento (opcional)

